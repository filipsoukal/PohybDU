using System;
using System.Linq;

namespace PohybDU {
	class Program {
		static void Main(string[] args) {
			double s1 = 15;
			double s2 = 10;
			double v1 = 15;
			double v2 = 20;
			double t = 0;
			double distance = 0;
			bool acceleration = true;
			double a1 = 2;
			double a2 = 1;
			double step = 0.01;
			int arraycount = 0;
			double[] doubleArray = new double[100];

			for(t=0;t < 1; t+=step) {
				if(acceleration == true) {
					s1 = s1 - ((v1 + (a1*t)) * step);
					s2 = s2 - ((v2 + (a2*t)) * step);
				}
				else {
				s1 = s1 - v1 * step;
				s2 = s2 - v2 * step;
				}
				distance = DistanceBetweenPoints(s1, s2);
				doubleArray[arraycount] = distance;
				arraycount++;
				Console.WriteLine($"distance :{distance} s1 : {s1} s2 :{s2} t :{t}");
			}
			double DistanceBetweenPoints(double s1,double s2) {
				return Math.Sqrt(Math.Pow(Math.Abs(s1),2) + Math.Pow(Math.Abs(s2),2));
			}
			Console.WriteLine(doubleArray.Min());
			Console.ReadLine();
		}
	}
}
