internal class Program
{

    private static void Main(string[] args)
    {
        int familyAllowance = 0;
        int childAllowance = 0;
        double incomeTax = 0;
        double incomeTaxRate=0;

        Console.WriteLine("Enter overall salary: ");
        double overallSalary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter marital status \n(b/B:subay, e/E:married, d/D:separated): ");

        char maritalStatus = char.Parse(Console.ReadLine());

        if (maritalStatus == 'E' || maritalStatus == 'e')
        {
            familyAllowance += 50;
        }
        if (maritalStatus == 'E' || maritalStatus == 'D' || maritalStatus == 'e' || maritalStatus == 'd')
        {
            Console.WriteLine("Please enter number of child/children");
            int currentChildCount = int.Parse(Console.ReadLine());
            for (int childCount = 1, allowanceAmount = 30; childCount <= currentChildCount; childCount++)
            {
                if (childCount < 4)
                {
                    childAllowance += allowanceAmount;
                    allowanceAmount -= 5;
                }
                else
                {
                    childAllowance += 15;
                }
            }
        }

        overallSalary = overallSalary + familyAllowance + childAllowance;
        
        double netSalary = overallSalary;

        Console.WriteLine("Enter the status of disability(y/Y:Yes, n/N:No): ");
        char disabilityStatus = char.Parse(Console.ReadLine());


        if (disabilityStatus == 'Y' || disabilityStatus == 'y')
        {
            if (overallSalary <= 1000)
            {
                incomeTaxRate = 15 / 2;
                incomeTaxRate=Math.Round(incomeTaxRate);
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;

            }
            else if (overallSalary > 1000 & overallSalary <= 2000)
            {
                incomeTaxRate = 20 / 2;
                incomeTaxRate = Math.Round(incomeTaxRate);
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;
            }
            else if (overallSalary > 2000 & overallSalary <= 3000)
            {
                incomeTaxRate = 25 / 2;
                incomeTaxRate = Math.Round(incomeTaxRate);
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;
            }
            else if (overallSalary > 3000)
            {
                incomeTaxRate = 30 / 2;
                incomeTaxRate = Math.Round(incomeTaxRate);
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;
            }
        }
        else
        {
            if (overallSalary <= 1000)
            {
                incomeTaxRate = 15;
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;

            }
            else if (overallSalary > 1000 & overallSalary <= 2000)
            {
                incomeTaxRate = 20;
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;
            }
            else if (overallSalary > 2000 & overallSalary <= 3000)
            {
                incomeTaxRate = 25;
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;
            }
            else if (overallSalary > 3000)
            {
                incomeTaxRate = 30;
                incomeTax = overallSalary * incomeTaxRate / 100;
                netSalary -= incomeTax;
            }
        }

        Console.WriteLine("Family allowance is: " + familyAllowance + "AZN");
        Console.WriteLine("Child allowance is: " + childAllowance + "AZN");
        Console.WriteLine("Income tax rate is: " + incomeTaxRate + "%");
        Console.WriteLine("Tax income is: " + Math.Round(incomeTax,2) + "AZN");
        Console.WriteLine("Overall salary is: " + Math.Round(overallSalary,2) + "AZN");
        Console.WriteLine("Net salary is: " + Math.Round(netSalary,2) + "AZN");

    }
}