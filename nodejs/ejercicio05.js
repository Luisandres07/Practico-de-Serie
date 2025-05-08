function ejerci4(vim, m, vi, r, vi1, r1, n) {
    let am = vim / m;
    let t = "";

    for (let i = 1; i <= n; i++) {
        am = am * m;
        console.log("Valor AM= "+am)
        const a = vi + (i - 1) * r;
        const b = vi1 + (i - 1) * r1;
        t += "ln(" + am + ")+" + a + "/" + b + "+";
       // console.log("Valor I = "+i+"  Valor T="+t)
 
    }
console.log("-----------------------------------------------------")
    return t;
}


function generarSerie(numerador, denominador, n) {
    let resultado = "F = ";
    let paso = 1;
    let contador = 0;
  
    while (contador < n && numerador >= 1) {
      resultado += `√(${numerador}/${denominador})`;
  
   
      contador++;
 
      paso++;
      numerador -= paso;
      denominador += paso;
       
      if (contador < n && numerador >= 1) {
        resultado += " + ";
      }
    
    }
  
    return resultado;
  }
  
  // Ejemplo de uso
  console.log(generarSerie(99, 2,4000));
  
  
  

//console.log("F= "+ejerci4(10,10,2,2,1.7,0.2,5))