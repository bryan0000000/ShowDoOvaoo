using Windows.Media.Capture.Core;

namespace ShowDoOvaoo
{

   public class Gerente
   { 
     public int Pontuacao{ get; private set; }
      int NivelAtual=0;
      void Inicializar()
      {
         
         Pontuacao=0;
         NivelAtual=0;
         ProximaQuestao();

      }
      
    List<Questao> ListaQuestao = new List<Questao>();
    List<int> ListasQuestaoRespondidas = new List<int>();
     Questao QuestaoAtual;
     
     public Gerente(Label questao,  Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
     {
        CriarPergunta( questao,  resposta1,  resposta2,  resposta3,  resposta4,  resposta5);
     }
     
     void CriarPergunta(Label labelPerguntaa,  Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
     {
        var Q1 = new Questao();
        Q1.ConfigurarDesenho( labelPerguntaa, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05) ;
        Q1.questao = "Quanto é 15+15?";
        Q1.resposta1 ="1";
        Q1.resposta2 ="16";
        Q1.resposta3 ="1515";
        Q1.resposta4 ="30";
        Q1.resposta5 ="2001";
        Q1.RespostaC = 4 ;
        ListaQuestao.Add(Q1);
        ProximaQuestao();

        var Q2 = new Questao();
        Q2.ConfigurarDesenho( labelPerguntaa, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05) ;
        Q2.questao = "faz mau tomar banho?";
        Q2.resposta1 ="sim";
        Q2.resposta2 ="não";
        Q2.resposta3 ="talvez";
        Q2.resposta4 ="Q?";
        Q2.resposta5 ="analise";
        Q2.RespostaC = 5 ;
        ListaQuestao.Add(Q2);
        ProximaQuestao();

        var Q3 = new Questao();
        Q3.ConfigurarDesenho( labelPerguntaa, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05) ;
        Q3.questao = "cod e melhor que fortinait?";
        Q3.resposta1 ="obvio";
        Q3.resposta2 ="não";
        Q3.resposta3 ="como é amigo";
        Q3.resposta4 ="não quero dizer";
        Q3.resposta5 ="meu ovo";
        Q3.RespostaC = 1 ;
        ListaQuestao.Add(Q3);
        ProximaQuestao();

        var Q4 = new Questao();
        Q4.ConfigurarDesenho( labelPerguntaa, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05) ;
        Q4.questao = "se um cara te chama par uma briga, oque tu faiz?";
        Q4.resposta1 ="vo pra cima";
        Q4.resposta2 ="corro";
        Q4.resposta3 ="puxo um oitao";
        Q4.resposta4 ="falo que sei capoeira";
        Q4.resposta5 ="chamo meus manos";
        Q4.RespostaC = 3 ;
        ListaQuestao.Add(Q4);
        ProximaQuestao();











     }

       public void ProximaQuestao()
        {

            var RandomNumber = Random.Shared.Next(0, ListaQuestao.Count);
            while (ListasQuestaoRespondidas.Contains(RandomNumber))
            
            ListasQuestaoRespondidas.Add(RandomNumber);
            QuestaoAtual = ListaQuestao[RandomNumber];
            QuestaoAtual.Desenhar();
        }

       public async void verificaresposdta(int RespostaR)
       {
         
          
         if(QuestaoAtual.verificaresposdta(RespostaR))
         {
            await Task.Delay(100);
            AdicionarPontuacao(NivelAtual);
             if (NivelAtual == 10)
                await App.Current.MainPage.DisplayAlert("VOCÊ ACERTOU TUDO!", "PARABÉNS!", "OK");
            ProximaQuestao();
            ProximaQuestao();
         }
         else
         {
            await App.Current.MainPage.DisplayAlert("tu perdeu","","ok");
            Inicializar();
         }
       }
     
     void AdicionarPontuacao(int n)
     {
   if( n==1)
      Pontuacao=1000;
   else if( n==2)
      Pontuacao=2000;
   else if( n==2)
      Pontuacao=3000;
   else if( n==2)
      Pontuacao=4000;
   else if( n==2)
      Pontuacao=5000;
   else if( n==2)
      Pontuacao=6000;
   else if( n==2)
      Pontuacao=7000;
   else if( n==2)
      Pontuacao=8000;
   else if( n==2)
      Pontuacao=10000;
   else if( n==2)
      Pontuacao=11000;
   else if( n==2)
      Pontuacao=12000;      

     }
   }
}