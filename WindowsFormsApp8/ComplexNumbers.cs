using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class ComplexNumbers
    {
        double module;
        double arg;
        const char i = 'i';
        static int fast = 0;
        Random r = new Random(fast++);

        public double Module { get => module; set => module = value; }
        public double Arg { get => arg; set => arg = value; }
        public ComplexNumbers()
        {
            module = r.Next(0, 20);
            arg = r.Next(0, 20);
        }
        public ComplexNumbers Pow(int n)
        {
            ComplexNumbers temp = new ComplexNumbers();
            temp.module = Math.Pow(module, 1 / n);
            temp.arg = Math.Cos((arg + 2 * Math.PI) / 2) + i * Math.Sin((arg + 2 * Math.PI) / 2);
            return temp;
        }
        public string Output()
        {
            return $"{module} * (cos({arg}) + {i} * sin({arg})))\n";
        }
        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers action = new ComplexNumbers();
            action.module = a.module + b.module;
            action.arg = a.arg + b.arg;
            return action;
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers action = new ComplexNumbers();
            action.module = a.module - b.module;
            action.arg = a.arg - b.arg;
            return action;
        }
        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers action = new ComplexNumbers();
            action.module = a.module * b.module;
            action.arg = a.arg + b.arg;
            return action;
        }
        public static ComplexNumbers operator /(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers action = new ComplexNumbers();
            action.module = a.module / b.module;
            action.arg = a.arg - b.arg;
            return action;
        }
    }

}
