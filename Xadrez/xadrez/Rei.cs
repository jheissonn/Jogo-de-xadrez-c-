using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class Rei:Peca
    {
        public Rei(Tabuleiro tab, Cor cor) :base(tab, cor)
            { }
        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;

        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);
            // perguntar se tem alguem na posição acima
            pos.defirnirValores(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // ne
            pos.defirnirValores(posicao.linha - 1, posicao.coluna+1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // direita
            pos.defirnirValores(posicao.linha , posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // sudeste
            pos.defirnirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // abaixo
            pos.defirnirValores(posicao.linha + 1, posicao.coluna );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // sudoeste
            pos.defirnirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // esqueda
            pos.defirnirValores(posicao.linha , posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            // noroeste
            pos.defirnirValores(posicao.linha - 1, posicao.coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;




        }
    }
}
