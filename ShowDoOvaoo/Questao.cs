namespace ShowDoOvaoo
{
  public class Questao
  {
    public string questao { get; set; }

    //---------------------------------------------------------------
    public string resposta1 { get; set; }
    public string resposta2 { get; set; }
    public string resposta3 { get; set; }
    public string resposta4 { get; set; }
    public string resposta5 { get; set; }
    public int NivelDaPergunta; 
    public int RespostaR;
    public int RespostaC;
    public Label? labelPergunta;
    private Button? buttonrep1;
    private Button? buttonrep2;
    private Button? buttonrep3;
    private Button? buttonrep4;
    private Button? buttonrep5;

 



   
    public Questao(Label labelPerguntaa, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
    {
      labelPergunta = labelPerguntaa;
      buttonrep1 = btnResposta01;
      buttonrep2 = btnResposta02;
      buttonrep3 = btnResposta03;
      buttonrep4 = btnResposta04;
      buttonrep5 = btnResposta05;
    }

        public Questao()
        {
        }

        public void ConfigurarDesenho(Label labelPerguntaa,  Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05 )
  {
    labelPergunta = labelPerguntaa ;
    buttonrep1 = btnResposta01;
    buttonrep2 = btnResposta02;
    buttonrep3 = btnResposta03;
    buttonrep4 = btnResposta04;
    buttonrep5 = btnResposta05;
  
  }

    public void Desenhar( )
    {
      labelPergunta.Text = questao;
      buttonrep1.Text = resposta1;
      buttonrep2.Text = resposta2;
      buttonrep3.Text = resposta3;
      buttonrep4.Text = resposta4;
      buttonrep5.Text = resposta5;

      this.buttonrep1!.BackgroundColor = Color.FromArgb("#773babd3");
           this.buttonrep1!.TextColor       = Colors.White;
           this.buttonrep2!.BackgroundColor = Color.FromArgb("#773babd3");
           this.buttonrep2!.TextColor       = Colors.White;
           this.buttonrep3!.BackgroundColor = Color.FromArgb("#773babd3");
           this.buttonrep3!.TextColor       = Colors.White;
           this.buttonrep4!.BackgroundColor = Color.FromArgb("#773babd3");
           this.buttonrep4!.TextColor       = Colors.White;
           this.buttonrep5!.BackgroundColor = Color.FromArgb("#773babd3");
           this.buttonrep5!.TextColor       = Colors.White;
    }

    public bool verificaresposdta(int RespostaC)
    {
      if (RespostaR == RespostaC)
      {
        var bot = QualBot(RespostaC);
        bot.BackgroundColor = Colors.Green;
        return true;
      }
      else
      {
        return false;
      }
    }
     
    private Button QualBot (int RespostaC)
    {
      if (RespostaC == 1)
        return buttonrep1;
      else if (RespostaC == 2)
        return buttonrep2;
      else if (RespostaC == 3)
        return buttonrep3;
      else if (RespostaC == 4)
        return buttonrep4;
      else if (RespostaC == 5)
        return buttonrep5;
        else
        return null;
    }
  }
}



