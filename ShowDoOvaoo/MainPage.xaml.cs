namespace ShowDoOvaoo;

public partial class MainPage : ContentPage
{

	int pular=0;
  public Gerente gerente;
	public MainPage()
	{
		InitializeComponent();
		
		gerente = new Gerente( labelPerguntaa,  btnResposta01,  btnResposta02,  btnResposta03,  btnResposta04,  btnResposta05);
		
	}
              void btnResposta001 (object sender, EventArgs args)
            {
              gerente!.verificaresposdta(1);
		    }

			  void btnResposta002 (object sender, EventArgs args)
            {
              gerente!.verificaresposdta(2);
		    }
			  void btnResposta003 (object sender, EventArgs args)
            {
              gerente!.verificaresposdta(3);
		    }
			  void btnResposta004 (object sender, EventArgs args)
            {
              gerente!.verificaresposdta(4);
		    }
			  void btnResposta005 (object sender, EventArgs args)
            {
              gerente!.verificaresposdta(5);
		    }

			  void btnpular (object s, EventArgs a)
            {
				if(pular==2)
				(s as Button).IsVisible=false;
				else
				{
                gerente!.ProximaQuestao();
			    pular++;
				}
                if
			    (pular==2) 
				puladoido.Text="pular:1X";
				if
			    (pular==1) 
				puladoido.Text="pular:2X";
				if
			    (pular==0) 
				puladoido.Text="pular:3X";
			 
			 
			 
		




		    }



}



	


