namespace Trabalho2
{
    public class Circuito:ICircuito
    {
        float resistencia1;
        float resistencia2;
        float fonte;

        public Circuito(float r1, float r2, float f) {
            resistencia1 = r1;
            resistencia2 = r2;
            fonte = f;
        }

        public Circuito(float r1, float r2) {
            resistencia1 = r1;
            resistencia2 = r2;
        }

        public void setR1(float r1) {
            resistencia1 = r1;
        }

        public float getR1() {
            return resistencia1;
        }

        public void setR2(float r2) {
            resistencia2 = r2;
        }

        public float getR2() {
            return resistencia2;
        }

        public void setF1(float f) {
            fonte = f;
        }

        public float getF1() {
            return fonte;
        }

        public float resistenciaSerie() {
            return (resistencia1 + resistencia2);
        }

        public float resistenciaParalelo() {
            return ((resistencia1 * resistencia2) / (resistencia1 + resistencia2));
        }

        public float correnteTotalSerie() {
            float corrente = fonte / resistenciaSerie();
            return corrente;
        }

        public float correnteTotalParalelo() {
            float corrente = fonte / resistenciaParalelo();
            return corrente;
        }

        public float potenciaFonteSerie() {
            float potencia = fonte * correnteTotalSerie();
            return potencia;
        }

        public float potenciaFonteParalelo() {
            float potencia = fonte * correnteTotalParalelo();
            return potencia;
        }

        public static Circuito potObjSerie(Circuito c1, Circuito c2) {
            if (c1.potenciaFonteSerie() < c2.potenciaFonteSerie()) {
                return c1;
            }
            return c2;
        }

        public static Circuito potObjParalelo(Circuito c1, Circuito c2) {
            if (c1.potenciaFonteParalelo() < c2.potenciaFonteParalelo()) {
                return c1;
            }
            return c2;
        }
    }
}