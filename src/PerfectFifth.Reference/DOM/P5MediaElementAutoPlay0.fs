module P5Reference.DOM.P5MediaElementAutoPlay0

open P5.Core
open P5.DOM
open P5.Rendering

let mutable videoElement: P5MediaElement option = None

let draw p5 =
    noCanvas p5

    let onVideoLoad () =
        match videoElement with
        | Some el ->
            el.autoplay ()
            el.setVolume 0
            el.setSize 100 100
        | _ -> ()

    videoElement <- Some <| createVideoWithCallback p5 "assets/small.mp4" onVideoLoad

let run node = display node draw
