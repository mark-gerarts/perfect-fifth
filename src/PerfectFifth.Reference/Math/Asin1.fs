module P5Reference.Math.Asin1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let a = pi + pi / 3.0
    let s = sin a
    let asn = asin s
    // Prints: "4.1887902 : -0.86602540 : -1.0471975"
    print p5 (sprintf "%f : %f : %f" a s asn)

let run node = display node draw
