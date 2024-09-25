namespace ShowDoOvaoo;

public partial class MainPage : ContentPage
{
	
  public Gerente gerente;
	public MainPage()
	{
		InitializeComponent();
		
		gerente = new Gerente( questao,  resposta1,  resposta2,  resposta3,  resposta4,  resposta5);
		gerente.ProximaQuestao();
	}
              void but1 (object sender, EventArgs e)
            {
              gerente!.verificaresposdta(1);
		    }

			  void but002 (object sender, EventArgs e)
            {
              gerente!.verificaresposdta(2);
		    }
			  void but003 (object sender, EventArgs e)
            {
              gerente!.verificaresposdta(3);
		    }
			  void but004 (object sender, EventArgs e)
            {
              gerente!.verificaresposdta(4);
		    }
			  void but005 (object sender, EventArgs e)
            {
              gerente!.verificaresposdta(5);
		    }			

}



	


