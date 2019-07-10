//in the name of ALLAH
using System;


//fix problems in childs
//check correct rubik
//calculate heroistic
//doing ida function
//doing msa function


namespace Project {
    class Program {
        static void Main(string[] args){

            Console.WriteLine("SML RUBIK SOLVER");
            Input input = new Input();
            Output.printWithMap (input.getData());
            Rubik rubik = new Rubik(input.getData());
            if (input.getMsa() == 1){
                Console.WriteLine(rubik.msa());
            }else {
                Console.WriteLine(rubik.ida());
            }
        }
    }
}
