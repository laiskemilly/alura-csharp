Doacao doacao1 = new Doacao();
doacao1.IdDoacao = 1;
doacao1.ValorDoacao = 500.00f;
doacao1.DoacaoAnonima = true;
doacao1.TipoConta = "P";
doacao1.InfoDoacao();

Doacao doacao2 = new Doacao();
doacao2.IdDoacao = 2;
doacao2.ValorDoacao = 1000.00f;
doacao2.DoacaoAnonima = true;
doacao2.TipoConta = "C";
doacao2.InfoDoacao();

Doacao doacao3 = new Doacao();
doacao3.IdDoacao = 3;
doacao3.ValorDoacao = 300.50f;
doacao3.DoacaoAnonima = false;
doacao3.TipoConta= "P";
doacao3.InfoDoacao();