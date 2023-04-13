module P5Reference.Math.Pow

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    let eSize = 3.0 // Original Size
    let eLoc = 10.0 // Original Location

    circle p5 eLoc eLoc eSize
    circle p5 (eLoc * 2.0) (eLoc * 2.0) (pown eSize 2)
    circle p5 (eLoc * 4.0) (eLoc * 4.0) (pown eSize 3)
    circle p5 (eLoc * 8.0) (eLoc * 8.0) (pown eSize 4)

let run node = display node draw
