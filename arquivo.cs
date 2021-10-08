namespace Trabalho2
{
    public interface arquivo
    {
         private:
          float resistencia1;
          float resistencia2;
          float fonte;

        public:
          Circuito(float,float,float);
          Circuito(float,float);

          void setR1(float);
          float getR1();
          void setR2(float);
          float getR2();
          void setF1(float);
          float getF1();

          float resistenciaSerie();
          float resistenciaParalelo();
          float correnteTotalSerie();
          float correnteTotalParalelo();
          float potenciaFonteSerie();
          float potenciaFonteParalelo();
          static Circuito potObjSerie(Circuito, Circuito);
          static Circuito potObjParalelo(Circuito, Circuito);

    }
}