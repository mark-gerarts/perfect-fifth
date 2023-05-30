module P5Reference.DOM.P5MediaElementAutoPlay1

open P5.Core
open P5.DOM
open P5.Rendering

let mutable videoElement: P5MediaElement option = None

let setup p5 =
    noCanvas p5

    let onVideoLoad () =
        match videoElement with
        | Some el ->
            el.setAutoplay false
            el.setVolume 0
            el.setSize 100 100
        | _ -> ()

    videoElement <- Some <| createVideoWithCallback p5 "assets/small.mp4" onVideoLoad

let draw _ _ = ()

let onMouseClicked p5 _ =
    match videoElement with
    | Some el -> el.play ()
    | _ -> ()

let run node =
    play node setup noUpdate draw [ OnMouseClicked(Effect onMouseClicked) ]
