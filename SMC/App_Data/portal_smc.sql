-- Table: public.dados_pessoais

-- DROP TABLE public.dados_pessoais;

CREATE TABLE public.dados_pessoais
(
    id serial NOT NULL,
    nome character varying(300) COLLATE pg_catalog."default" NOT NULL,
    cpf character varying(11) COLLATE pg_catalog."default" NOT NULL,
    telefone character varying(11) COLLATE pg_catalog."default",
    email character varying(100) COLLATE pg_catalog."default",
    endereco character varying(300) COLLATE pg_catalog."default",
    CONSTRAINT pk_id PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.dados_pessoais
    OWNER to postgres;



-- Table: public.autenticacao

-- DROP TABLE public.autenticacao;

CREATE TABLE public.autenticacao
(
    id serial NOT NULL,
    id_dados_pessoais integer NOT NULL,
    login character varying(80) COLLATE pg_catalog."default" NOT NULL,
    senha character varying(80) COLLATE pg_catalog."default" NOT NULL,
    tipo_usuario integer,
    CONSTRAINT pk_autenticao PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.autenticacao
    OWNER to postgres;