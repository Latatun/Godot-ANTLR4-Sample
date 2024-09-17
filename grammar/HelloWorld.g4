grammar HelloWorld;

import Shared;

options {
	caseInsensitive = true;
}

hello: HELLO WORLD;

HELLO: 'HELLO';
WORLD: 'WORLD';