using System;

class main {
  static void Main() {
    var data = CSVReader.Read();

    Random random = new Random();
    var temp = random.Next(0, 10);
    String answer = data[temp]["Name"];//정답
    answer=answer.ToLower();
    int chance = 6;
    String userInput="";
    String prt="";
  
    Console.WriteLine(answer);
    while(chance-- > 0){//6회
      if (String.Equals(userInput,answer)){
        Console.WriteLine("정답입니다.");
        break;
      }
      
      prt = "";//값 초기화
      userInput="";
      
      userInput = System.Console.ReadLine();//사용자 입력, userInput 입력
  
      for(int a=0; a<5; a++){//정답 확인, userInput 기반으로 prt 작성
        char c = userInput[a];
        if(c==answer[a]){
          prt=string.Concat(prt,'O');
        }
        else if(answer.IndexOf(c)!=-1){
          prt=string.Concat(prt,'-');
        }
        else prt = string.Concat(prt,'X');
      }
      
      Console.WriteLine(userInput);
      Console.WriteLine(prt);//남은 횟수 출력
      Console.WriteLine(chance+"회 남았습니다.");
      Console.WriteLine();
    }//while 끝

    Console.WriteLine("정답은" + answer);
    Console.WriteLine("종료");//게임 종료
  }
}
