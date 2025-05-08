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


console.log("F= "+ejerci4(10,10,2,2,1.7,0.2,5))