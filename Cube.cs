using System.Collections.Generic;

namespace Project {
    public class Cube {

        private int[] data;
        private Cube[] nodes;
        private bool initialized;
        int f;
        int g;
        int h;
        List <int> result;

        public Cube(int[] DATA,int COST,List <int> RESULT){
            data = DATA;
            nodes = new Cube[10];
            initialized = false;
            g = COST;
            h = getHuristic();
            f = g + h;
            result = RESULT;
        }
        public void initNodes(){
            int[][] childs = Creator.create(data);
            for (int i=1; i < 10; i++){
                List <int> nodeResult = new List<int>(result);
                nodeResult.Add(i);
                nodes[i]= new Cube(childs[i],f,nodeResult);
            }
            initialized = true;
        }
        public Cube getNode(int NUMBER){
            if (initialized == false){
                initNodes();
            }
            return nodes[NUMBER];
        }
        public int[] getData(){
            return data;
        }
        private int getHuristic(){
            int[] heurictics = new int [2];
            for (int i = 0; i < heurictics.Length; i++){
                heurictics[i] = 0;
            }

            // teedade gheir yeksan dar har morabaa
            int h1 = 0;
            for (int m = 0;m <= 5;m++){
                int correct = data[4+(m*10)];
                for(int i = 0+(m*10),j = 8+(m*10); i <= j ;i = i+1){
                    if (data[i] != correct){
                        h1 ++;
                    } 
                }
            }
            heurictics[0] = h1;

            // teedade gheir yeksan dar har morabaa
            int h2 = 0;
            for (int m = 0;m <= 5;m++){
                int correct = data[4+(m*10)];
                for(int i = 0+(m*10),j = 8+(m*10); i <= j ;i=i+2){
                    if (data[i] != correct){
                        h2 ++;
                    } 
                }
            }
            heurictics[1] = h2;


            int max = 0;
            for (int j = 0; j < heurictics.Length; j++){
                if (heurictics[j]> max){
                    max = heurictics[j];
                }
            }
            return h1 + h2;

        }
        public int getF (){
            return f;
        }
        public List <int> getResult (){
            return result;
        } 
    }
} 