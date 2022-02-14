int[] A = { 3,8,9,7,6};
int K = 5;
int length = A.Length;

int[] B = new int[length];

if (K < length)
{

    for (int i = K - 1; i < length; i++)
    {
        int afterRotationValue = i - K + 1;
        B[afterRotationValue] = A[i];
    }
    for (int i = K; i < length; i++)
    {
        int afterRotationValue = i - K;
        B[i] = A[afterRotationValue];
    }
}
else 
{
    B = A;
}
foreach (int i in B)
{
    Console.WriteLine(i.ToString());
}