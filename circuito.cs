namespace Trabalho2
{
    public class circuito:arquivo
    {
        Circuito(float r1, float r2, float f) {
            resistencia1 = r1;
            resistencia2 = r2;
            fonte = f;
        }

        Circuito(float r1, float r2) {
            resistencia1 = r1;
            resistencia2 = r2;
        }

        void setR1(float r1) {
            resistencia1 = r1;
        }

        float getR1() {
            return resistencia1;
        }

        void setR2(float r2) {
            resistencia2 = r2;
        }

        float getR2() {
            return resistencia2;
        }

        void setF1(float f) {
            fonte = f;
        }

        float getF1() {
            return fonte;
        }

        float resistenciaSerie() {
            return (resistencia1 + resistencia2);
        }

        float resistenciaParalelo() {
            return ((resistencia1 * resistencia2) / (resistencia1 + resistencia2));
        }

        float correnteTotalSerie() {
            float corrente = fonte / resistenciaSerie();
            return corrente;
        }

        float correnteTotalParalelo() {
            float corrente = fonte / resistenciaParalelo();
            return corrente;
        }

        float potenciaFonteSerie() {
            float potencia = fonte * correnteTotalSerie();
            return potencia;
        }

        float potenciaFonteParalelo() {
            float potencia = fonte * correnteTotalParalelo();
            return potencia;
        }

        Circuito potObjSerie(Circuito c1, Circuito c2) {
            if (c1.potenciaFonteSerie() < c2.potenciaFonteSerie()) {
                return c1;
            }
            return c2;
        }

        Circuito potObjParalelo(Circuito c1, Circuito c2) {
            if (c1.potenciaFonteParalelo() < c2.potenciaFonteParalelo()) {
                return c1;
            }
            return c2;
        }
    }
}