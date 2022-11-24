using System;

class Program{
    static void Main(String[] args){
        Queue<int>size_1 = new Queue<int>();
        Queue<int>size_2 = new Queue<int>();
        Queue<int>size_3 = new Queue<int>();

        char size = 'x';
        int L=1, M=2, S=3;
        
        while( size == 'S' || size == 'M' || size == 'L' || size == 'a' ){
            size = char.Parse(Console.ReadLine());
            
            if(size == 'S'){
                size_1.Push(S);
            }
            else if (size == 'M'){
                size_1.Push(M);
                for (int i = 0; i < 3; i++){
                    size_2.Push(S);
                }
            }
            else if (size == 'L'){
                size_1.Push(L);
                for(int i = 0; i<2; i++){
                    size_2.Push(M);
                    for(int j =0; j<3; j++){
                        size_3.Push(S);
                    }
                }
            }
        }
        for(int n=0; n < size_1.GetLength(); n++){
            Console.Write("{0}",size_1.Get(n));
        }
        
        PrintInfo(size_1,size_2,size_3);
    }

    static void PrintInfo(Queue<int> size_1,Queue<int> size_2,Queue<int> size_3){
        for(int s1 =0; s1< size_1.GetLength(); s1++){
            Console.Write("{0}",size_1.Get(s1));
        }
        for(int s2 =0; s2< size_1.GetLength(); s2++){
            Console.Write("{0}",size_1.Get(s2));
        }
        for(int s3 =0; s3< size_1.GetLength(); s3++){
            Console.Write("{0}",size_1.Get(s3));
        }
    }

    
}
