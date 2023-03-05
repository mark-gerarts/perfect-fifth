module P5Reference

open Browser.Dom
open P5.Core
open P5Reference

let runSketch name canvasSelector =
    let node = Element <| document.querySelector (canvasSelector)

    match name with
    | "Environment/Describe0" -> Environment.Describe0.run node
    | "Environment/Describe1" -> Environment.Describe1.run node
    | "Environment/DescribeElement" -> Environment.DescribeElement.run node
    | "Shape/Circle" -> Shape.Circle.run node
    | _ -> failwith <| "No sketch with name " + name + " exists"
