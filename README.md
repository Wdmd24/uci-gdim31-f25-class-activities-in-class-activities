# in-class-activities
## Devlogs
### W1

1. After the camera is no longer a child of the cat, the camera will not going to follow the cat anymore. 
This is because the moving script is attach on the cat, which only allow the cat and its children to move. 
So as long as the camera isn't the child of cat, the moving script will not be able to controll the camera. 

2. https://wdmd24.itch.io/class-act-1


### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1. This is because r, g and b are the value between 0.0 to 1.0, using float will be the best way to represent them. 

2. Since the bounce can be best illustrate by integer, using int will be the best way.

3. Since it loss a semicolon, which creartes a error.


### W3
In class Activiy1
1. public String GetResponse (int friendship_level){}

2. public void SetLightDimness (float sanity){}

3. public bool DidPlayerHitBeat (float timing){} 

In class Activity2
1. Suppose the class is a human, the component will be that human's orgin like heart, brain whatever. 


In class Activity3

1. Everytime they bounce, the method 'OnCollisionEnter2D' will be activate for once. In it, the speed of ball will increase and method GetColorMultiplier will be activated for once as well. As long as the average speed is larger than  _speedThreshold, GetColorMultiplier will return 1.5f. this value will times the color of ballRenderer, which causes the color to be brighter (Since when r, g and b increase, the object's color will be closer to white). So if the balls bounce for too many times, their color will be very bright.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 