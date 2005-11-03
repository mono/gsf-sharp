AM_CFLAGS = -Wall -Wunused -Wmissing-prototypes -Wmissing-declarations

INCLUDES = $(GSF_CFLAGS)
lib_LTLIBRARIES = libgsfglue.la

GSF_GLUE_SOURCES = \
	gsf-doc-prop-glue.c	\
	gsf-doc-prop-glue.h

libgsfglue_la_SOURCES = $(GSF_GLUE_SOURCES)

libgsfglue_la_LDFLAGS = -module -avoid-version -no-undefined

libgsfglue_la_LIBADD = $(GSF_LIBS)
