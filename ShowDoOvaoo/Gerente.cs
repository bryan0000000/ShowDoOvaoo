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

     public Gerente(Label questao,Label NivelDaPergunta, Button resposta1, Button resposta2, Button resposta3, Button resposta4, Button resposta5)
     {
        CriarPergunta( questao, NivelDaPergunta, resposta1,  resposta2,  resposta3,  resposta4,  resposta5);
     }
     
     void CriarPergunta(Label labelPergunta,Label NivelDaPergunta, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
     {
        var Q1 = new Questao();
        Q1.ConfigurarDesenho( labelPergunta,NivelDaPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05) ;
        Q1.questao = "Quanto é 15+15?";
        Q1.resposta1 ="1";
        Q1.resposta2 ="16";
        Q1.resposta3 ="1515";
        Q1.resposta4 ="30";
        Q1.resposta5 ="2001";
        Q1.RespostaC = 4 ;
        ListaQuestao.Add(Q1);
        ProximaQuestao();
     }

       public void ProximaQuestao()
        {

            var RandomNumber = Random.Shared.Next(0, ListaQuestao.Count);
            while (ListasQuestaoRespondidas.Contains(RandomNumber))
            {
                RandomNumber = Random.Shared.Next(0, ListaQuestao.Count);
            }
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
            NivelAtual ++;
            ProximaQuestao();
         }
         else
         {
            await App.Current.MainPage.DisplayAlert("ti perdeu","","ok");
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