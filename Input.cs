namespace Project {
    public class Input {
        private int[] data;
        private int msa;

        public Input(){
            msa = 0;
            data = new int[60];

            data [0] = 4; data [1] = 0; data [2] = 4;
            data [3] = 4; data [4] = 0; data [5] = 4;
            data [6] = 2; data [7] = 2; data [8] = 2;

            data [10] = 3; data [11] = 4; data [12] = 3;
            data [13] = 3; data [14] = 4; data [15] = 3;
            data [16] = 3; data [17] = 4; data [18] = 3;

            data [20] = 5; data [21] = 5; data [22] = 5;
            data [23] = 5; data [24] = 5; data [25] = 5;
            data [26] = 0; data [27] = 1; data [28] = 0;

            data [30] = 0; data [31] = 1; data [32] = 0;
            data [33] = 0; data [34] = 1; data [35] = 0;
            data [36] = 2; data [37] = 2; data [38] = 2;

            data [40] = 2; data [41] = 2; data [42] = 2;
            data [43] = 2; data [44] = 2; data [45] = 2;
            data [46] = 3; data [47] = 4; data [48] = 3;

            data [50] = 1; data [51] = 3; data [52] = 1;
            data [53] = 1; data [54] = 3; data [55] = 1;
            data [56] = 1; data [57] = 3; data [58] = 1;

            
            // data [0] = 4; data [1] = 0; data [2] = 4;
            // data [3] = 4; data [4] = 0; data [5] = 4;
            // data [6] = 4; data [7] = 2; data [8] = 4;

            // data [10] = 3; data [11] = 4; data [12] = 3;
            // data [13] = 3; data [14] = 4; data [15] = 3;
            // data [16] = 5; data [17] = 4; data [18] = 5;

            // data [20] = 5; data [21] = 5; data [22] = 5;
            // data [23] = 5; data [24] = 5; data [25] = 5;
            // data [26] = 0; data [27] = 0; data [28] = 0;

            // data [30] = 0; data [31] = 1; data [32] = 0;
            // data [33] = 0; data [34] = 1; data [35] = 0;
            // data [36] = 2; data [37] = 1; data [38] = 2;

            // data [40] = 2; data [41] = 2; data [42] = 2;
            // data [43] = 2; data [44] = 2; data [45] = 2;
            // data [46] = 3; data [47] = 3; data [48] = 3;

            // data [50] = 1; data [51] = 5; data [52] = 1;
            // data [53] = 1; data [54] = 3; data [55] = 1;
            // data [56] = 1; data [57] = 3; data [58] = 1;

        }
        public Input(int[] DATA){
            msa = 0;
            data = DATA;
        }
        public Input(int[] DATA,int MSA){
            msa = 1;
            data = DATA;
        }
        public int[] getData(){
            return data;
        }
        public int getMsa(){
            return msa;
        }
    }
}
