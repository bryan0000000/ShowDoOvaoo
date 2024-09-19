namespace ShowDoOvaoo
{

   public class Gerente
   {
      
    List<Questao> ListaQuestao = new List<Questao>();
    List<int> ListasQuestaoRespondidas = new List<int>();
     
     Questao QuestaoAtual;

     public Gerente(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
     {
        CriarPergunta(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5);
     }
     
     void CriarPergunta(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
     {
        var Q1 = new Questao();
        Q1.Desenhar (Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5);
        Q1.questao = "Quanto é 15+15?";
        Q1.resposta1 ="1";
        Q1.resposta2 ="16";
        Q1.resposta3 ="1515";
        Q1.resposta4 ="30";
        Q1.resposta5 ="2001";
        Q1.RespostaC = 4 ;
        ListaQuestao.add(Q1);
     }
        
     




















































































   }
}