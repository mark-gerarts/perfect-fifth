module P5Reference.Math.Atan1

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let a = pi + pi / 3.0
    let t = tan a
    let at = atan t
    print p5 (sprintf "%f : %f : %f" a t at)

let run node = display node draw
