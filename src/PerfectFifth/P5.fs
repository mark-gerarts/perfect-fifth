namespace P5

module Core =

    open System
    open Fable.Core
    open Browser.Dom

    type IImage =
        interface
        end

    /// The methods on this class are for internal use only. You pass an
    /// instance to all functions, but never call a method on it.
    [<ImportAll("p5")>]
    type P5(sketch: Func<obj, Unit>, ?node: Browser.Types.Element) =
        interface IImage

        member _.preload
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.setup
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.draw
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.mouseMoved
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.mousePressed
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.mouseClicked
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

        member _.windowResized
            with get (): obj = jsNative
            and set (_: obj): Unit = jsNative

    type Event =
        // @todo: legit event classes instead of dummy objects.
        | MouseMoved of obj
        | MousePressed of obj
        | MouseClicked of obj
        | WindowResized of obj

    type Node =
        | Selector of string
        | Element of Browser.Types.Element
        | NoNode

    type Init<'preloadState, 'state> =
        | Setup of setup: (P5 -> 'state)
        | PreloadAndSetup of preload: (P5 -> 'preloadState) * setup: (P5 -> 'preloadState -> 'state)

    type Sketch<'preloadState, 'state> =
        { init: Init<'preloadState, 'state>
          update: P5 -> 'state -> 'state
          draw: P5 -> 'state -> Unit
          eventHandler: P5 -> Event -> 'state -> 'state
          node: Node }

    /// Disables the draw function from being called continuously. This should
    /// belong in P5.Structure, but because we need this in `display`, we would
    /// run into dependency issues.
    [<Emit("$0.noLoop()")>]
    let noLoop (p5: P5) : Unit = jsNative

    /// Returns the time in milliseconds since the start of the sketch. This
    /// should belong in P5.Time, but because we need this in `animate`, we
    /// would run into dependency issues.
    [<Emit("$0.millis()")>]
    let millis (p5: P5) : int = jsNative

    let defaultSketch setup =
        { init = Setup setup
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          eventHandler = (fun _ _ -> id)
          node = NoNode }

    let defaultPreloadSketch preload setup =
        { init = PreloadAndSetup(preload, setup)
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          eventHandler = (fun _ _ -> id)
          node = NoNode }

    [<Global>]
    let console: JS.Console = jsNative

    let createSketch (sketch: Sketch<'preloadState, 'state>) : Unit =
        let nodeElement =
            match sketch.node with
            | Selector selector -> document.querySelector (selector)
            | Element element -> element
            | NoNode -> null

        let p5Sketch =
            // Inspired by https://github.com/aolney/fable-p5-demo
            new Func<obj, unit>(fun boxedP5 ->
                let mutable state = Unchecked.defaultof<'state>
                let p5 = unbox<P5> boxedP5

                // For testing purposes, delete this later.
                console.log p5

                match sketch.init with
                | PreloadAndSetup(preload, setup) ->
                    let mutable preloadState = Unchecked.defaultof<'preloadState>
                    p5.preload <- fun () -> preloadState <- preload p5
                    p5.setup <- fun () -> state <- setup p5 preloadState
                | Setup setup -> p5.setup <- fun () -> state <- setup p5

                p5.draw <-
                    fun () ->
                        state <- sketch.update p5 state
                        sketch.draw p5 state

                p5.mouseMoved <- fun ev -> state <- sketch.eventHandler p5 (MouseMoved ev) state

                p5.mousePressed <- fun ev -> state <- sketch.eventHandler p5 (MousePressed ev) state

                p5.mouseClicked <- fun ev -> state <- sketch.eventHandler p5 (MouseClicked ev) state

                p5.windowResized <- fun ev -> state <- sketch.eventHandler p5 (WindowResized ev) state

                ())

        new P5(p5Sketch, nodeElement) |> ignore

        ()

    let noSetup (_: P5) = ()

    let noUpdate (_: P5) = id

    /// Create a static sketch.
    let display (node: Node) (draw: P5 -> Unit) : Unit =
        let setupWithLoopDisabled (p5: P5) =
            noLoop p5
            ()

        let drawDropState (p5: P5) _ = draw p5

        createSketch
            { defaultSketch setupWithLoopDisabled with
                draw = drawDropState
                node = node }

    let displayWithPreload (node: Node) (preload: P5 -> 'a) (draw: P5 -> 'a -> Unit) : Unit =
        let setupWithLoopDisabled (p5: P5) preloadState =
            noLoop p5
            preloadState

        createSketch
            { defaultPreloadSketch preload setupWithLoopDisabled with
                draw = draw
                node = node }

    /// Create a simple animation sketch, which draws something based on the
    /// time elapsed.
    let animate (node: Node) (setup: P5 -> Unit) (draw: P5 -> int -> Unit) : Unit =
        let setupWithoutState p5 =
            setup p5
            ()

        let drawWithTimeElapsed (p5: P5) _ = draw p5 (millis p5)

        createSketch
            { defaultSketch setupWithoutState with
                draw = drawWithTimeElapsed
                node = node }

    /// Create a simulation sketch. It starts with an initial state, which gets
    /// updated every step.
    let simulate (node: Node) (setup: P5 -> 'a) (update: P5 -> 'a -> 'a) (draw: P5 -> 'a -> Unit) : Unit =
        createSketch
            { defaultSketch setup with
                update = update
                draw = draw
                node = node }

    let simulateWithPreload
        (node: Node)
        (preload: P5 -> 'a)
        (setup: P5 -> 'a -> 'b)
        (update: P5 -> 'b -> 'b)
        (draw: P5 -> 'b -> Unit)
        : Unit =
        createSketch
            { defaultPreloadSketch preload setup with
                update = update
                draw = draw
                node = node }

    /// Create a sketch with all functionality: handling state and events.
    let play
        (node: Node)
        (setup: P5 -> 'a)
        (update: P5 -> 'a -> 'a)
        (draw: P5 -> 'a -> Unit)
        (eventHandler: P5 -> Event -> 'a -> 'a)
        : Unit =
        createSketch
            { init = Setup setup
              update = update
              draw = draw
              eventHandler = eventHandler
              node = node }

    let playWithPreload
        (node: Node)
        (preload: P5 -> 'a)
        (setup: P5 -> 'a -> 'b)
        (update: P5 -> 'b -> 'b)
        (draw: P5 -> 'b -> Unit)
        (eventHandler: P5 -> Event -> 'b -> 'b)
        : Unit =
        createSketch
            { init = PreloadAndSetup(preload, setup)
              update = update
              draw = draw
              eventHandler = eventHandler
              node = node }
