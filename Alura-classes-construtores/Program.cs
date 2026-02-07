Episodio ep1 = new(2, "Técnicas de aprendizado", 45);
ep1.AddConvidados("Ana");
ep1.AddConvidados("Maria");

Episodio ep2 = new(1, "Técnicas de leitura", 30);
ep2.AddConvidados("Laís");
ep2.AddConvidados("Lorenna");

Episodio ep3 = new(3, "Técnicas de foco", 50);
ep3.AddConvidados("Maria");
ep3.AddConvidados("Andre");

Podcast podcast = new("Podcast especial", "Laís");
podcast.AddEpisodio(ep1);
podcast.AddEpisodio(ep2);
podcast.AddEpisodio(ep3);
podcast.ExibirDetalhes();