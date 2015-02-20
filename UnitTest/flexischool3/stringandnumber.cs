using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flexischool3
{
 
    public class StringAndNumber
    {
        private string m_printStr;

        private int m_curnumber;

      

        private StringAndNumber()
        {
        }

        public StringAndNumber(string printStr, int curnumber)
        {
            m_printStr = printStr;
            m_curnumber = curnumber;
        }

        public string printStr
        {
            get { return m_printStr; }
        }

        public int curnumber
        {
            get { return m_curnumber; }
        }
       
        public void workout(int amount )
        {
            if ((amount % 5 == 0) && (amount % 3 == 0))
            {
                m_printStr = "FizzBuzz";
            }
            else
            {
                if (amount % 5 == 0)
                {
                    m_printStr = "Buzz";
                }
                else
                {

                    if (amount % 3 == 0)
                    {
                        m_printStr = "Fizz"; ;
                    }
                    else
                    {
                        m_printStr = amount.ToString();
                    }
                }
            }
          
        }

        
        public static void Main()
        {
            StringAndNumber ba = new StringAndNumber("what", 1); 

             for (int j=1; j<=100; j++){
                 ba.workout(j);
              
            Console.WriteLine("Current curnumber is ${0}, print string is ", ba.curnumber.ToString()+ ba.printStr);
             }
        }

    }
}