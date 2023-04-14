module P5Reference.Math.P5VectorToString0

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let v = createVector2D 20 30
    print p5 (string v) // prints "p5.Vector Object : [20, 30, 0]"

let run node = display node draw
