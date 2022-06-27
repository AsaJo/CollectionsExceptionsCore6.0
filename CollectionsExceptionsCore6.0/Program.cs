
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int[] intArray = new int[10];

//intArray[0] = 64;
//intArray[1] = 128;
//intArray[2] = 256;  
//intArray[3] = 512;
//Console.WriteLine("Hello, World!");

//****************************** Collections - Multidimensional Arrays ********************

//int[] intArray1 = new int[5];
//int[,] intArray2 = new int[5, 5];
//int[,,] intArray3 = new int[5, 5, 5];
//int[,,,] intArray4 = new int[5, 5, 5, 5];

//intArray1[3] = 12;
//intArray2[0, 3] = 57;
//intArray3[1, 2, 5] = 68;
//intArray4[2, 4, 1, 2] = 24;

//***************************** Collections - Lists ***************************************



//List<int> listInt = new List<int>();

//**************************** Generics ***************************************************
//Dictionary<int, string> dict = new Dictionary<int, string>();
//Dictionary<TKey, TValue> keyValuePairs = new Dictionary<TKey, TValue>();
// Add class Tkey and TValue

//***************************** Collections - Dictionaries*********************************


Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();

dict["today"] = DateTime.Now;

Console.WriteLine(DateTime.Now);

//**************************** Collections - List Initialization **************************

List<int> listInt = new List<int> { 5, 7, 8, 1, 2, 7, 1 };

new Dictionary<string, string> { {"Marcus", "marcus@lexicon.se" },
                                 {"Kent","kent@lexicon.se" },
                                 {"Simon","says@lexicon.se" },
                                };



