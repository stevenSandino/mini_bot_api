DROP TABLE IF EXISTS "Answer";
CREATE TABLE IF NOT EXISTS "Answer"
(
"IdAnswer" bigint NOT NULL GENERATED ALWAYS AS IDENTITY (INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036 CACHE 1),
"Question" character varying(120) COLLATE pg_catalog."default" NOT NULL,
"Answer" character varying(120) COLLATE pg_catalog."default" NOT NULL,
CONSTRAINT "Answer_pkey" PRIMARY KEY ("IdAnswer")
);
INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('what is my name', 'your name is Steven');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('How is the weather', 'it is good');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('what time is it', 'it is mid day');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('Where I am', 'you are in Costa Rica');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('Are you a Spy', 'YES');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('Whats my favorite color', 'Blue');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('what are you', 'I am a Chat Bot');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('How are you', 'I am fine and you');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('I am good', 'nice');

INSERT INTO public."Answer"(
"Question", "Answer"
)
VALUES ('Is this the last question', 'Yes it is');

