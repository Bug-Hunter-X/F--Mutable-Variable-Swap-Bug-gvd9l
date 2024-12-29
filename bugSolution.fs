let mutable x = 10
let mutable y = 20

let swap (x, y) = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let (x, y) = swap (x, y)
printfn "%d %d" x y

//Alternative solution using ref cells:

let xRef = ref 10
let yRef = ref 20

let swapRef xRef yRef = 
    let temp = !xRef
    xRef := !yRef
    yRef := temp

swapRef xRef yRef
printfn "%d %d" !xRef !yRef