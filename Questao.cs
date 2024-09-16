namespace ShowDoOvaoo;
   public class Questao
   
   {
     public string questao { get ; set;}
     
    //---------------------------------------------------------------
     public string resposta1 { get ; set;}
     public string resposta2 { get ; set;}
     public string resposta3 { get ; set;}
     public string resposta4 { get ; set;}
     public string resposta5 { get ; set;}
     public int NivelDaPergunta;
     public int RespostaR
     private Label labelPergunta;
     private Button  buttonrep1;
      private Button buttonrep2;
      private Button buttonrep3;
      private Button buttonrep4;
      private Button buttonrep5;
   
   public void desenhar()
   {
     labelPergunta.taxt=questao
     buttonrep1.taxt=resposta1
     buttonrep2.taxt=resposta2
     buttonrep3.taxt=resposta3
     buttonrep4.taxt=resposta4
     buttonrep5.taxt=resposta5        
   }
   
   
   
   public void Questao()
   {}
   public Questao(Label per,Button bot1,Button bot2,Button bot3,Button bot4,Button bot5,) 
    {
     labelPergunta=per
     buttonrep=bot1
     buttonrep=bot2
     buttonrep=bot3
     buttonrep=bot4
     buttonrep=bot5
    }
      
     public bool verificaresposdta(int RespostaR)
     {
    if (RespostaR == RespostaC) 
        return true 
        else false
      var bot = QualBot(RespostaR);
      bot  BackgroundColor.Color Green
     }
     private Button QualBot(int RespostaR)
     {
        if( RespostaR == 1)
        return buttonrep1,
        else if( RespostaR == 2)
        return buttonrep2,
        else if()k
     }
   }
  
  public void configurar(Label per,Button bot1,Button bot2,Button bot3,Button bot4,Button bot5,) 
    {
     labelPergunta=per
     buttonrep=bot1
     buttonrep=bot2
     buttonrep=bot3
     buttonrep=bot4
     buttonrep=bot5
    }