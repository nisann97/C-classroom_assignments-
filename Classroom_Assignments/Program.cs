Console.WriteLine("Hello, World!");

//int studentAge = 25;

//Console.WriteLine(studentAge);





//string name = "Nisa";
//string surname = "Narimanova";
//string result = name + surname;

//Console.WriteLine(result);




//bool isOnline = true;

//Console.WriteLine(isOnline);





//bool isOnline = true;

//Console.WriteLine(isOnline.GetType());


//bool isOnline = true;

//if(isOnline)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



//int age = 29;

//if (age > 29)
//{
//    Console.WriteLine("Qocalirsan");
//}
//else if (age == 29) 
//{
//    Console.WriteLine("Yaxshisan");
//}
//else
//{
//    Console.WriteLine("Gencsen");

//}






//int number = 30;

//string result = number > 30 ? "Qocasan" : "Yaxshisan";
//Console.WriteLine(result);





//Console.WriteLine("Username daxil edin:");
//string username = Console.ReadLine();


//Console.WriteLine("Passwordu daxil edin");

////string password = Console.ReadLine();

////if (username == "User1234" && password == "123456")
////{
////    Console.WriteLine("Successful login");

////}
////else
////{
//////    Console.WriteLine("failed login");
////}
///


//int weekDay = 2;
//switch (weekDay)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:

//        Console.WriteLine("Tuesday");

//        break;
//    default:
//        Console.WriteLine("Not found");
//        break;
//}




//int[] nums1 = new int[10];
//int[] nums2 = new int[3] { 1, 4, 5 };
//int[] nums3 = { 3, 4, 5, 9, };




//int[] nums = { 3, 2, 6, 8, 9 };

//for(int i=0; i<nums.Length; i++)
//{
//    Console.WriteLine(i);
//}




//int[] nums = { 3, 2, 6, 8, 9 };

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}





//int[] nums = { 3, 2, 6, 8, 9 };

//for(int i=0; i<nums.Length; i++)
//{
//    Console.WriteLine(i + nums[i]);
//}


//int[] nums = { 3, 2, 6, 8, 9 };

//for(int i=0; i<nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        Console.WriteLine(nums[i]);

//        break;
//    }
//}




//int[] nums = { 3, 2, 6, 2, 8, 9, 2 };

//int count = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        count++;
//    }
//} Console.WriteLine(count);


//int[] nums = { 2, 4, 6, 8, 3 };

//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        sum += i;
//    }

//} Console.WriteLine(sum);





//int[] nums = { 2, 4, 5, 7, 2, 8 };

//int sumElem = 0;
//int sumIndex = 0;
//int result = 0;


//for(int i=0; i<nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        sumElem += nums[i];
//        sumIndex += i;
//    }
//} result = sumElem - sumIndex;

//Console.WriteLine(result);



//int[] nums = { 3, 2, 6, 8, 9, 2 };

//int sumElem = 0;
//int sumIndex = 0;

//bool istrue = true;
//int result = 0;

//for(int i=0; i<nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        sumElem += nums[i];
//        sumIndex += i;
//    }
//}
//if (istrue)
//{
//    result = sumElem - sumIndex;
//    Console.WriteLine(result);
//}
//else
//{ Console.WriteLine("test");
//}




//int[] nums = { 3, 2, 6, 2, 9, 2 };

// for(int i=0; i<nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        Console.WriteLine(nums[i]);
//        continue;
//    }
//    Console.WriteLine(nums[i]);
//}


//int[] nums = { 3, 2, 6, 2, 8, 9 };

//foreach(var item in nums)
//{
//    if (item == 2)
//    {
//        Console.WriteLine(item);
//        break;
//    }
//}


//DateTime date = DateTime.Now;

//Console.WriteLine(date);


//DateTime date = DateTime.Now.AddDays(5);

//Console.WriteLine(date);

//string date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");

//Console.WriteLine(date);