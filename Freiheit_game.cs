using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextController : MonoBehaviour {

public Text text;

private enum States {Room0, window0, door0, toilet0, convo, window1, toilet1, noise};
private States MyState;
	// Use this for initialization
	void Start () {
		text.text = "\n \n 'F R E I H E I T' - Please press [SPACEBAR] to begin your journey. \n \n" + "Copyright © 2018 by Cody James Ryan " +
		  			"All rights reserved. No part of this publication may be reproduced, distributed, or transmitted in any form or by any means, " + 
		  			"including photocopying, recording, or other electronic or mechanical methods, without the prior written permission of the " +
		  			"publisher, except in the case of brief quotations embodied in critical reviews and certain other noncommercial " +
		  			"uses permitted by copyright law. For permission requests, write to the publisher, addressed " + 
		  			"“Attention: Permissions Coordinator,” at the email below. \n \n " + "PlVSVLTRA969@GMAIL.COM"; 
			MyState = States.Room0;	
			
	}
	
	// Update is called once per frame
	void Update () {
		if (MyState == States.Room0) {
			state_room0 (); 
		} 
	
	}
	
	void state_room0 () { 
	
		if (Input.GetKeyDown(KeyCode.Space)) { 
			
			text.text="Dawn breaks on a new day, and you awaken in a groggy stupor. The sun filling the small cold room you're in. " +
				"Your head hurts and you don't remember how you arrived here, as you shake off the sleep, you hear voices in the distance talking. " + 
					"As you look around the room: There's the simple cot you were sleeping on, a small toilet in the corner of the room, " + 
					"and a door and a small slit window. Otherwise the cold room is empty and drafty. You continue hearing voices beyond the door. \n\n" +
					"Press 'T' to look at the toilet, 'W' to look at the window slit, 'D' to approach the door";    
			if (Input.GetKeyDown(KeyCode.S)) {
			}
		}
	}
	
}
