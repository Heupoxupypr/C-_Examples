AllType[] Copy<AllType> (AllType[] array)
{
AllType[] result = new AllType[array.Length];
for (int i = 0; i < array.Length; i++)
{
result[i] = array[i];
}
return result;
}

string[] strArray = new string[3] {"1","2332","fdfdf"};
int[] intArray = new int[3]{1,2,3};
bool[] boolArray = new bool[3]{true, false, false};

string[] resStrArray = Copy(strArray);
int[] resIntArray = Copy(intArray);
var resBoolArray = Copy(boolArray);