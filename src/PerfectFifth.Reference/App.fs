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
    | "Environment/TextOutput0" -> Environment.TextOutput0.run node
    | "Environment/TextOutput1" -> Environment.TextOutput1.run node
    | "Environment/GridOutput0" -> Environment.GridOutput0.run node
    | "Environment/GridOutput1" -> Environment.GridOutput1.run node
    | "Environment/Print" -> Environment.Print.run node
    | "Environment/FrameCount" -> Environment.FrameCount.run node
    | "Environment/DeltaTime" -> Environment.DeltaTime.run node
    | "Shape/Circle" -> Shape.Circle.run node
    | _ -> failwith <| "No sketch with name " + name + " exists"
