namespace Trabalho2
{
    public interface ICircuito
    {
          public void setR1(float r1);
          public float getR1();
          public void setR2(float r2);
          public float getR2();
          public void setF1(float f);
          public float getF1();

          public float resistenciaSerie();
          public float resistenciaParalelo();
          public float correnteTotalSerie();
          public float correnteTotalParalelo();
          public float potenciaFonteSerie();
          public float potenciaFonteParalelo();
    }
}