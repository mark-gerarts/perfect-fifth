module P5Reference.DOM.CreateVideo

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM

let mutable vid: P5MediaElement option = None

let draw p5 =
    noCanvas p5

    let vidLoad () =
        match vid with
        | None -> ()
        | Some vid ->
            vid.loop ()
            vid.setVolume 0

    let video =
        createVideoFromArrayWithCallback p5 [| "assets/small.mp4"; "assets/small.ogg"; "assets/small.webm" |] vidLoad

    video.setSize 100 100
    vid <- Some video


let run node = display node draw
