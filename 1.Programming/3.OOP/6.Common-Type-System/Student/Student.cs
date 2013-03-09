using System;
using System.Text;

public class Student : ICloneable, IComparable<Student>
{
    //Properties
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int SSN { get; set; }
    public string PermanentAddress { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
    public int Course { get; set; }
    public Specialty Specialty { get; set; }
    public University Univercity { get; set; }
    public Faculty Faculty { get; set; }

    //Object methods
    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Student s = obj as Student;
        if ((object)s == null)
        {
            return false;
        }

        return FirstName == s.FirstName && MiddleName == s.MiddleName && LastName == s.LastName && SSN == s.SSN &&
            PermanentAddress == s.PermanentAddress && MobilePhone == s.MobilePhone && Email == s.Email &&
            Course == s.Course && Specialty == s.Specialty && Univercity == s.Univercity && Faculty == s.Faculty;
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode() ^
            PermanentAddress.GetHashCode() ^ MobilePhone.GetHashCode() ^ Email.GetHashCode() ^
            Course.GetHashCode() ^ Specialty.GetHashCode() ^ Univercity.GetHashCode() ^ Faculty.GetHashCode();
    }

    public static bool operator ==(Student first, Student second)
    {
        return first.Equals(second);
    }

    public static bool operator !=(Student first, Student second)
    {
        return !(first == second);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("First name: {0}; ", FirstName);
        sb.AppendFormat("Middle name: {0}; ", MiddleName);
        sb.AppendFormat("Last name: {0}; ", LastName);
        sb.AppendFormat("SSN: {0}; ", SSN);
        sb.AppendFormat("Permanent address: {0}; ", PermanentAddress);
        sb.AppendFormat("Mobile phone: {0}; ", MobilePhone);
        sb.AppendFormat("Email: {0}; ", Email);
        sb.AppendFormat("Course: {0}; ", Course);
        sb.AppendFormat("Univercity: {0}; ", Univercity);
        sb.AppendFormat("Faculty: {0}; ", Faculty);
        return sb.ToString();
    }

    //IClonable Methods
    public Student Clone()
    {
        Student newStud = new Student() {
            FirstName = this.FirstName,
            MiddleName = this.MiddleName,
            LastName = this.LastName,
            SSN = this.SSN,
            PermanentAddress = this.PermanentAddress,
            MobilePhone = this.MobilePhone,
            Email = this.Email,
            Course = this.Course,
            Specialty = this.Specialty,
            Univercity = this.Univercity,
            Faculty = this.Faculty
        };

        return newStud;
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }

    //IComparable Methods
    public int CompareTo(Student other)
    {
        int firstNameCmp = this.FirstName.CompareTo(other.FirstName);

        if (firstNameCmp == 0)
        {
            int middleNameCmp = this.MiddleName.CompareTo(other.MiddleName);
            if (middleNameCmp == 0)
            {
                int lastNameCmp = this.LastName.CompareTo(other.LastName);

                if (lastNameCmp == 0)
                {
                    int ssnCmp = other.SSN.CompareTo(this.SSN);
                    return ssnCmp;

                }
                else
                {
                    return lastNameCmp;
                }
            }
            else
            {
                return middleNameCmp;
            }
        }
        else
        {
            return firstNameCmp;
        }
    }
}

