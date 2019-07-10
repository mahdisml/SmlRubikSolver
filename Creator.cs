//______________________________________________________ DATA
//
//                 [10] [11] [12]
//                 [13] [14] [15]
//                 [16] [17] [18]
//
// [20] [21] [22]  [00] [01] [02]  [40] [41] [42]  [50] [51] [52]
// [23] [24] [25]  [03] [04] [05]  [43] [44] [45]  [53] [54] [55]
// [26] [27] [28]  [06] [07] [08]  [46] [47] [48]  [56] [57] [58]
//
//           s1    [30] [31] [32]   s7   s8   s9
//           s2    [33] [34] [35]
//           s3    [36] [37] [38]
//
//                  s4   s5   s6
//
//______________________________________________________ 3D
//
//                 [18] [17] [16]
//                 [15] [14] [13]
//                 [12] [11] [10]
//
// [26] [23] [20]  [02] [01] [00]  [42] [45] [48]  [50] [51] [52]
// [27] [24] [21]  [05] [04] [03]  [41] [44] [47]  [53] [54] [55]
// [28] [25] [22]  [08] [07] [06]  [40] [43] [46]  [56] [57] [58]
//
//           s1    [30] [31] [32]   s7   s8   s9
//           s2    [33] [34] [35]
//           s3    [36] [37] [38]
//
//                  s4   s5   s6


namespace Project{
    public static class Creator {
        public static int[][] create(int[] data){
            int[] s1 = (int[]) data.Clone();
            int[] s2 = (int[]) data.Clone();
            int[] s3 = (int[]) data.Clone();
            int[] s4 = (int[]) data.Clone();
            int[] s5 = (int[]) data.Clone();
            int[] s6 = (int[]) data.Clone();
            int[] s7 = (int[]) data.Clone();
            int[] s8 = (int[]) data.Clone();
            int[] s9 = (int[]) data.Clone();

            // s1
            s1[50] = data[52];
            s1[51] = data[55];
            s1[52] = data[58];
            s1[53] = data[51];
            s1[54] = data[54];
            s1[55] = data[57];
            s1[56] = data[50];
            s1[57] = data[53];
            s1[58] = data[56];

            s1[30] = data[20];
            s1[31] = data[21];
            s1[32] = data[22];

            s1[20] = data[10];
            s1[21] = data[11];
            s1[22] = data[12];

            s1[10] = data[40];
            s1[11] = data[41];
            s1[12] = data[42];

            s1[40] = data[30];
            s1[41] = data[31];
            s1[42] = data[32];

            // s2
            s2[33] = data[23];
            s2[34] = data[24];
            s2[35] = data[25];

            s2[23] = data[13];
            s2[24] = data[14];
            s2[25] = data[15];

            s2[13] = data[43];
            s2[14] = data[44];
            s2[15] = data[45];

            s2[43] = data[33];
            s2[44] = data[34];
            s2[45] = data[35];

            // s3
            s3[0] = data[6];
            s3[1] = data[3];
            s3[2] = data[0];
            s3[3] = data[7];
            s3[4] = data[4];
            s3[5] = data[1];
            s3[6] = data[8];
            s3[7] = data[5];
            s3[8] = data[2];

            s3[36] = data[26];
            s3[37] = data[27];
            s3[38] = data[28];

            s3[26] = data[16];
            s3[27] = data[17];
            s3[28] = data[18];

            s3[16] = data[46];
            s3[17] = data[47];
            s3[18] = data[48];

            s3[46] = data[36];
            s3[47] = data[37];
            s3[48] = data[38];

            // s4
            s4[20] = data[22];
            s4[21] = data[25];
            s4[22] = data[28];
            s4[23] = data[21];
            s4[24] = data[24];
            s4[25] = data[27];
            s4[26] = data[20];
            s4[27] = data[23];
            s4[28] = data[26];

            s4[30] = data[8];
            s4[33] = data[5];
            s4[36] = data[2];

            s4[50] = data[30];
            s4[53] = data[33];
            s4[56] = data[36];

            s4[12] = data[56];
            s4[15] = data[53];
            s4[18] = data[50];

            s4[8] = data[18];
            s4[5] = data[15];
            s4[2] = data[12];

            // s5
            s5[31] = data[7];
            s5[34] = data[4];
            s5[37] = data[1];

            s5[51] = data[31];
            s5[54] = data[34];
            s5[57] = data[37];

            s5[17] = data[51];
            s5[14] = data[54];
            s5[11] = data[57];

            s5[7] = data[17];
            s5[4] = data[14];
            s5[1] = data[11];

            // s6
            s6[40] = data[46];
            s6[41] = data[43];
            s6[42] = data[40];
            s6[43] = data[47];
            s6[44] = data[44];
            s6[45] = data[41];
            s6[46] = data[48];
            s6[47] = data[45];
            s6[48] = data[42];

            s6[52] = data[32];
            s6[55] = data[35];
            s6[58] = data[38];

            s6[32] = data[6];
            s6[35] = data[3];
            s6[38] = data[0];

            s6[6] = data[16];
            s6[3] = data[13];
            s6[0] = data[10];

            s6[16] = data[52];
            s6[13] = data[55];
            s6[10] = data[58];

            // s7
            s7[30] = data[32];
            s7[31] = data[35];
            s7[32] = data[38];
            s7[33] = data[31];
            s7[34] = data[34];
            s7[35] = data[37];
            s7[36] = data[30];
            s7[37] = data[33];
            s7[38] = data[36];

            s7[40] = data[6];
            s7[43] = data[7];
            s7[46] = data[8];

            s7[56] = data[40];
            s7[57] = data[43];
            s7[58] = data[46];

            s7[28] = data[56];
            s7[25] = data[57];
            s7[22] = data[58];

            s7[6] = data[28];
            s7[7] = data[25];
            s7[8] = data[22];

            // s8
            s8[41] = data[5];
            s8[44] = data[6];
            s8[47] = data[7];

            s8[55] = data[41];
            s8[56] = data[44];
            s8[57] = data[47];

            s8[27] = data[55];
            s8[24] = data[56];
            s8[21] = data[57];

            s8[5] = data[27];
            s8[6] = data[24];
            s8[7] = data[21];

            // s9
            s9[10] = data[16];
            s9[11] = data[13];
            s9[12] = data[10];
            s9[13] = data[17];
            s9[14] = data[14];
            s9[15] = data[11];
            s9[16] = data[18];
            s9[17] = data[15];
            s9[18] = data[12];

            s9[42] = data[4];
            s9[45] = data[5];
            s9[48] = data[6];

            s9[54] = data[42];
            s9[55] = data[45];
            s9[56] = data[48];

            s9[26] = data[54];
            s9[23] = data[55];
            s9[20] = data[56];

            s9[4] = data[26];
            s9[5] = data[23];
            s9[6] = data[20];

            int [][] output = new int[10][];
            output [1]=s1;
            output [2]=s2;
            output [3]=s3;
            output [4]=s4;
            output [5]=s5;
            output [6]=s6;
            output [7]=s7;
            output [8]=s8;
            output [9]=s9;

            return output;
        }
    }
}