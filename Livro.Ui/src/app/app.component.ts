import { Component, OnInit } from '@angular/core';
import { ApiService } from './util/services/api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {

  livroId: number;
  nomeLivro: string;
  nomeAutor: string;
  ativo: boolean;
  novoShow: boolean;
  editarShow: boolean;
  listaLivro: any;
  showMensagemSucesso: boolean;

  constructor(private api: ApiService) {}

  ngOnInit(): void {
    this.getLivros();
  }

  excluirLivro(livro) {
    this.api.post("livro/delete", livro).subscribe(data => {
      this.getLivros();
    });
  }

  getLivros() {
    this.api.get("livro/getallascendingbyname").subscribe(data => {
      this.listaLivro = [];
      this.listaLivro = data.json();
    });
  }

  novoLivro() {
    this.ativo = false;
    this.novoShow = true;
  }

  voltar() {
    this.novoShow = false;
    this.editarShow = false;
    this.showMensagemSucesso = false;
  }

  salvarLivro() {
    this.api.post("livro/insert", {
      Nome: this.nomeLivro,
      NomeAutor: this.nomeAutor,
      Ativo: this.ativo
    }).subscribe(data => {
      this.showMensagemSucesso = true;
      this.getLivros();
      setTimeout(_ => {
        this.voltar();
      }, 1000);
    });
  }

  editarLivro(livro) {
    this.livroId = livro.LivroId;
    this.nomeLivro = livro.Nome;
    this.nomeAutor = livro.NomeAutor;
    this.ativo = livro.Ativo;
    this.editarShow = true;
  }

  salvarEdicaoLivro() {
    this.api.post("livro/update", {
      LivroId: this.livroId,
      Nome: this.nomeLivro,
      NomeAutor: this.nomeAutor,
      Ativo: this.ativo
    }).subscribe(data => {
      this.showMensagemSucesso = true;
      this.getLivros();
      setTimeout(_ => {
        this.voltar();
      }, 1000);
    });
  }
}
