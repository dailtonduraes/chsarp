using System;

namespace ModificadorParam {
    class Calculator {
        public static int sum(params int[] numbers) {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        public static int triple(ref int x) {
            return x = x * 3;  
        }
    }
}
