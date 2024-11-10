using System;


namespace Rational
{
	// Test harness
	public class TestRational
	{
		public static void Main()
		{
            System.Reflection.MemberInfo attrInfo;
            attrInfo = typeof(Rational);
            object[] attrs = attrInfo.GetCustomAttributes(false);
            CustomAttribute.DeveloperInfoAttribute developerAttr;

            //developerAttr = (CustomAttribute.DeveloperInfoAttribute)attrs[0];
            //Console.WriteLine("Developer: {0}\tDate: {1}", developerAttr.Developer, developerAttr.Date);

            //developerAttr = (CustomAttribute.DeveloperInfoAttribute)attrs[1];
            //Console.WriteLine("Developer: {0}\tDate: {1}", developerAttr.Developer, developerAttr.Date);

            foreach (CustomAttribute.DeveloperInfoAttribute devAttr in attrs)
            {
                Console.WriteLine("Developer: {0}\tDate: {1}", devAttr.Developer, devAttr.Date);
            }


        }
	}
}
