namespace ShowDoOvaoo
{

   public class Gerente
   {
      
    List<Questao> ListaQuestao = new List<Questao>();
    List<int> ListasQuestaoRespondidas = new List<int>();
     
     Questao QuestaoAtual;

     public Gerente(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
     {
        CriarPergunta( per,  bot1,  bot2,  bot3,  bot4,  bot5);
     }
     
     void CriarPergunta(Label labelPergunta, Button buttonrep1, Button buttonrep2, Button buttonrep3, Button buttonrep4, Button buttonrep5)
     {
        var Q1 = new Questao();
        Q1.Desenhar (labelPergunta,buttonrep1,buttonrep2,buttonrep3,buttonrep4,buttonrep5 );
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

       void ProximaQuestao()
       {
          var NumAlert =Random.Shared.Next(0,ListaQuestao.Count);
          while(ListasQuestaoRespondidas.Contains(NumAlert));
          NumAlert=Random.Shared.Next(0,ListaQuestao.Count);
          ListasQuestaoRespondidas.Add(NumAlert);
          QuestaoAtual=ListaQuestao[NumAlert];
          QuestaoAtual.Desenhar();

       }   
     
   }
}