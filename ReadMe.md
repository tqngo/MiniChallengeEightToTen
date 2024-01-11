Tommy Ngo
1-11-24
Mini Challenge Eight to Ten - Endpoints
Design an API based on mini challenges from the Combine: Magic 8 Ball, Guess it and Restaurant Picker. Created multiple Controllers, Services, and Interfaces for each category. 
Peer Reviewed by Sebastian Breve-Sanchez, 12:45pm - The three controllers work as intended. The GuessIt has three endpoints for its three difficulties and the Magic8 and RestaurantPicker have one endpoint, with every endpoint doing what it should. The only unintended feature I found was in the RestaurantPicker: when a wrong input is given, it says to pick one of the following, with one of those options being "FastFood". However, when calling FastFood, its conditional has a space, "fast food". A simple fix, just choosing which one to roll with.