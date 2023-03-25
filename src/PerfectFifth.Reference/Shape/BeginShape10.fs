module P5Reference.Shape.BeginShape10

open P5.Core
open P5.Shape

let draw p5 =
    beginShapeWithMode p5 Tess
    vertex p5 20 20
    vertex p5 80 20
    vertex p5 80 40
    vertex p5 40 40
    vertex p5 40 60
    vertex p5 80 60
    vertex p5 80 80
    vertex p5 20 80
    endShapeAndClose p5

let run node = display node draw
