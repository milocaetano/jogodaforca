"# jogodaforca" 


Código de exemplo antigo

    public class Calculadora
    {


        public Calculadora()
        {
        }

        public int Soma(int x, int y)
        {

            int result = x + y;

            return result;
        }

        public int Multiplica(int x, int y)
        {

            int result = x * y;

            return result;
        }

        public static int SomaStatic(int x, int y)
        {

            int result = x + y;

            return result;
        }

    }


          //    if(args.Length == 3){

            //         if(args[0] == "somar"){

            //             int x = Convert.ToInt32(args[1]);
            //             int y = Convert.ToInt32(args[2]);
            //             Calculadora calc = new Calculadora();
            //             int result= calc.Soma(x, y);
            //             Console.WriteLine(result);                
            //         }

            //          if(args[0] == "multiplicar"){

            //             int x = Convert.ToInt32(args[1]);
            //             int y = Convert.ToInt32(args[2]);
            //             Calculadora calc = new Calculadora();
            //             int result= calc.Multiplica(x, y);
            //             Console.WriteLine(result);                
            //         }
            //    }


SCRIPT DO BANCO

USE [JOGODAFORCA]
GO

/****** Object:  Table [dbo].[Client]    Script Date: 07/11/2022 23:36:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nchar](100) NOT NULL,
	[Idade] [int] NOT NULL,
	[Altura] [int] NOT NULL
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Client]
           ([Nome]
           ,[Idade]
           ,[Altura])
     VALUES
           ('Murilo'
           ,34
           ,184)
GO


INSERT INTO [dbo].[Client]
           ([Nome]
           ,[Idade]
           ,[Altura])
     VALUES
           ('CAmilo Caetano'
           ,34
           ,174)

