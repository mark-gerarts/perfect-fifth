module P5Reference.Math.Abs

open P5.Core
open P5.Environment

let draw p5 =
    let x = -3
    let y = abs x

    print p5 (string x)
    print p5 (string y)

let run node = display node draw
