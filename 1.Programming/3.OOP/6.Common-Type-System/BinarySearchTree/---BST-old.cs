﻿//For info about the used algorithms check CLRS Introduction to Algorithms Chapter 12

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BST<TKey, TValue> : ICloneable where TKey : IComparable<TKey> 
{
    //Fields
    private TreeNode root = null;

    //Properties
    public TValue this[TKey key]
    {
        get
        {
            TreeNode searchResult = this.Search(this.root, key);
            if (searchResult == null)
            {
                throw new KeyNotFoundException();
            }
            return searchResult.Value;
        }
        set
        {
            TreeNode searchResult = this.Search(this.root, key);
            if (searchResult == null)
            {
                throw new KeyNotFoundException();
            }
            searchResult.Value = value;
        }
    }

    // Methods ----------------------------------------
    public void Add(TKey key, TValue value)
    {
        TreeNode newNode = new TreeNode(key, value, null, null, null);
        this.Insert(newNode);
    }

    public bool Remove(TKey key)
    {
        TreeNode node = Search(this.root, key);
        if (node == null)
        {
            return false;
        }
        Delete(node);
        return true;
    }

    public void Clear()
    {
        this.root = null;
    }

    public ICollection<TKey> Keys
    {
        get
        {
            ICollection<TKey> keys = new List<TKey>();
            InorderTreeWalk(this.root, x => keys.Add(x.Key));
            return keys;
        }
    }

    public ICollection<TValue> Values
    {
        get
        {
            ICollection<TValue> values = new List<TValue>();
            InorderTreeWalk(this.root, x => values.Add(x.Value));
            return values;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        InorderTreeWalk(this.root, x => sb.AppendFormat("[K: {0}; V: {1}] ", x.Key, x.Value));
        return sb.ToString();

        //StringBuilder sb = new StringBuilder();
        //ToStringHelper(this.root, sb);
        //return sb.ToString();
    }

    //private void ToStringHelper(TreeNode x, StringBuilder sb) 
    //{
    //    if (x != null) 
    //    {
    //        ToStringHelper(x.Left, sb);
    //        sb.AppendFormat("[K: {0}; V: {1}] ", x.Key, x.Value);
    //        ToStringHelper(x.Right, sb);
    //    }
    //}

    public override int GetHashCode()
    {
        int hash = 0;
        InorderTreeWalk(this.root, x => hash ^= x.GetHashCode());
        return hash;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        BST<TKey, TValue> tree = obj as BST<TKey, TValue>;
        if ((object)tree == null)
        {
            return false;
        }

        ICollection<TKey> thisKeys = this.Keys;
        ICollection<TKey> otherKeys = tree.Keys;

        if (thisKeys.Count != otherKeys.Count)
        {
            return false;
        }

        for (int i = 0; i < thisKeys.Count; i++)
        {
            if (thisKeys.ElementAt(i).CompareTo(otherKeys.ElementAt(i)) != 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool operator ==(BST<TKey, TValue> first, BST<TKey, TValue> second)
    {
        return first.Equals(second);
    }

    public static bool operator !=(BST<TKey, TValue> first, BST<TKey, TValue> second)
    {
        return !(first == second);
    }

    // Private Methods --------------------------------
    private void InorderTreeWalk(TreeNode node, Action<TreeNode> action) 
    {
        if (node != null)
        {
            InorderTreeWalk(node.Left, action);
            action(node);
            InorderTreeWalk(node.Right, action);
        }
    }

    private void PreorderTreeWalk(TreeNode node, Action<TreeNode> action)
    {
        if (node != null)
        {
            action(node);
            PreorderTreeWalk(node.Left, action);
            PreorderTreeWalk(node.Right, action);
        }
    }

    private TreeNode Search(TreeNode node, TKey key) 
    {
        int cmp = key.CompareTo(node.Key);

        if (node == null || cmp == 0)
        {
            return node;
        }
        if (cmp < 0)
        {
            return Search(node.Left, key);
        }
        else
        {
            return Search(node.Right, key);
        }
    }

    private void Insert(TreeNode newNode)
    {
        TreeNode parentNode = null;
        TreeNode currentNode = this.root;

        while (currentNode != null)
        {
            parentNode = currentNode;
            if (newNode.Key.CompareTo(currentNode.Key) < 0)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }

        newNode.Parent = parentNode;

        if (parentNode == null)
        {
            this.root = newNode;
        }
        else if (newNode.Key.CompareTo(parentNode.Key) < 0)
        {
            parentNode.Left = newNode;
        }
        else if (newNode.Key.CompareTo(parentNode.Key) > 0)
        {
            parentNode.Right = newNode;
        }
        else 
        {
            parentNode.Value = newNode.Value;
        }
    }

    private void Delete(TreeNode node)
    {
        if (node.Left == null)
        {
            Transplant(node, node.Right);
        }
        else if (node.Right == null)
        {
            Transplant(node, node.Left);
        }
        else
        {
            TreeNode y = Minimum(node.Right);
            if (!y.Parent.Equals(node))
            {
                Transplant(y, y.Right);
                y.Right = node.Right;
                y.Right.Parent = y;
            }
            Transplant(node, y);
            y.Left = node.Left;
            y.Left.Parent = y;
        }
    }

    private void Transplant(TreeNode u, TreeNode v)
    {
        if (u.Parent == null)
        {
            this.root = v;
        }
        else if (u.Equals(u.Parent.Left))
        {
            u.Parent.Left = v; // u = v;
        }
        else
        {
            u.Parent.Right = v;
        }
        if (v != null)
        {
            v.Parent = u.Parent;
        }
    }

    private TreeNode Minimum(TreeNode node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node;
    }

    // ICloneable Methods -----------------------------
    object ICloneable.Clone()
    {
        return this.Clone();
    }

    public BST<TKey, TValue> Clone()
    {
        //BST<TKey, TValue> newTree = new BST<TKey, TValue>();
        //newTree.root = CloneLeftRight(this.root);
        //ParentFix(newTree.root);
        //return newTree;

        BST<TKey, TValue> newTree = new BST<TKey, TValue>();
        PreorderTreeWalk(this.root, x => newTree.Add(x.Key, x.Value));
        return newTree;
    }

    // ICloneable Helper Methods -----------------------
    //private TreeNode CloneLeftRight(TreeNode node)
    //{
    //    if (node != null)
    //    {
    //        TreeNode newNode = new TreeNode(
    //            node.Key,
    //            node.Value,
    //            CloneLeftRight(node.Left),
    //            CloneLeftRight(node.Right),
    //            null);
    //        return newNode;
    //    }
    //    return null;
    //}

    //private void ParentFix(TreeNode node)
    //{
    //    if (node.Left != null)
    //    {
    //        node.Left.Parent = node;
    //        ParentFix(node.Left);
    //    }
    //    if (node.Right != null)
    //    {
    //        node.Right.Parent = node;
    //        ParentFix(node.Right);
    //    }
    //}

    //Inner class
    private class TreeNode
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Parent { get; set; }

        public TreeNode(TKey key, TValue val, TreeNode left, TreeNode right, TreeNode parent)
        {
            this.Key = key;
            this.Value = val;
            this.Left = left;
            this.Right = right;
            this.Parent = parent;
        }

        public override int GetHashCode()
        {
            return this.Key.GetHashCode() ^ this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            TreeNode node = obj as TreeNode;
            if ((object)node == null)
            {
                return false;
            }

            return this.Key.CompareTo(node.Key) == 0;
        }
    }
}

