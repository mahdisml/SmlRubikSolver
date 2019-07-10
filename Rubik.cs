using System.Collections.Generic;

namespace Project {
    public class Rubik {
        //possibility
        //ida
        private Cube start;

        public Rubik (int [] DATA){
            List <int> list = new List<int>();
            start = new Cube (DATA,0,list);
        }
        public string ida (){
            string result = "";
            if(check() == false){
                return "This Rubik is InCorrect";
            }
            if (isGoal(start)){
                return "this is Goal";
            }

            int limit = 0;
            List <Cube> fringe = new List<Cube>();
            for (int i = 1 ; i <= 9; i++){
                if (start.getNode(i).getF() > limit){
                   limit = start.getNode(i).getF();
                }
                fringe.Add(start.getNode(i));
            } 
            int nextLimit = limit + 999999999;

            while (true){
                fringe = new List<Cube>();
                for (int i = 1 ; i <= 9; i++){
                    fringe.Add(start.getNode(i));
                    if (isGoal(start.getNode(i))){
                        foreach (int m in start.getNode(i).getResult())  { 
                            result = " > " +m;
                        }
                        return result;
                    }
                } 
                for (int j=0;j<fringe.Count;j++){
                    Cube cube = fringe[j];
                    for (int i = 1 ; i <= 9; i++){
                        if (isGoal(cube)){
                                foreach (int m in cube.getResult())  { 
                                    result = " > " +m;
                                }
                            return result;
                            }
                        if (cube.getNode(i).getF() <= limit){
                            fringe.Add(cube.getNode(i));
                            if (isGoal(cube.getNode(i))){
                                foreach (int m in cube.getNode(i).getResult())  { 
                                    result = " > " +m;
                                }
                            return result;
                            }
                        }else {
                            if (cube.getNode(i).getF() < nextLimit){
                                nextLimit = cube.getNode(i).getF();
                            }
                        }
                    }
                    
                }
                limit = nextLimit;
                nextLimit =  nextLimit + 999999999;  
            }
            
            return "not Found" ;
        }
        public string msa (){
            return "its not ready";
        }
        private bool check (){
            string[] state = new string[6];


            return true;
        }
        private bool isGoal(Cube cube){
            int temp = -1;
            for (int m = 0;m <= 5;m++){
                for(int i = 0+(m*10),j = 8+(m*10); i <= j ;i++){
                   if (temp == -1){
                       temp = cube.getData()[i];
                   } 
                   if (temp != cube.getData()[i]){
                       return false;
                   }
                }
                temp = -1;
            }
            return true;
        }
    }
}