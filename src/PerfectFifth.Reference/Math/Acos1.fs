module P5Reference.Math.Acos1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let a = pi + pi / 4.0
    let c = cos a
    let ac = acos c
    // Prints: "3.926991 : -0.70710665 : 2.3561943"
    print p5 (sprintf "%f : %f : %f" a c ac)

let run node = display node draw
