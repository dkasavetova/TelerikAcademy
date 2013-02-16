#include<stdio.h>

int Compare(int h1, int m1, int h2, int m2)
{
    if (h1 > h2)
    {
        return 1;
    }
    else
    {
        if (h1 == h2)
        {
            if (m1 > m2)
            {
                return 1;
            }
            else
            {
                if (m1 < m2)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        else
        {
            return -1;
        }
    }
}

int main() {

    int asth, astm, aeth, aetm, bsth, bstm, beth, betm;

    scanf("%d %d %d %d", &asth, &astm, &aeth, &aetm);
    scanf("%d %d %d %d", &bsth, &bstm, &beth, &betm);

    if (Compare(bsth, bstm, asth, astm) <= 0 && Compare(beth, betm, asth, astm) >= 0 && Compare(beth, betm, aeth, aetm) <= 0)
    {
        printf("%d %d %d %d", asth, astm, beth, betm);
    }
    else if (Compare(bsth, bstm, asth, astm) >= 0 && Compare(bsth, bstm, aeth, aetm) <= 0 && Compare(beth, betm, aeth, aetm) >= 0)
    {
        printf("%d %d %d %d", bsth, bstm, aeth, aetm);
    }
    else if (Compare(bsth, bstm, asth, astm) >= 0 && Compare(bsth, bstm, aeth, aetm) < 0 && Compare(beth, betm, aeth, aetm) <= 0)
    {
        printf("%d %d %d %d", bsth, bstm, beth, betm);
    }
    else if (Compare(bsth, bstm, asth, astm) <= 0 && Compare(beth, betm, aeth, aetm) >= 0)
    {
        printf("%d %d %d %d", asth, astm, aeth, aetm);
    }
    else
    {
        printf("No");
    }

}





