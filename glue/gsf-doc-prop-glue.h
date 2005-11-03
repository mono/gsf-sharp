/* vim: set sw=8: -*- Mode: C; tab-width: 8; indent-tabs-mode: t; c-basic-offset: 8 -*- */
/*
 * gsf-msole-utils.c:
 * 
 * Authors: Veerapuram Varadhan <vvaradhan@novell.com>
 *
 * Copyright (C) 2005 Novell Inc
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of version 2.1 of the GNU Lesser General Public
 * License as published by the Free Software Foundation.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301
 * USA
 */

#ifndef GSF_DOC_PROP_GLUE_H_
#define GSF_DOC_PROP_GLUE_H_

#include <gsf/gsf-doc-meta-data.h>

void gsf_doc_prop_glue_get_val (GsfDocProp const *prop, GType *type, GValue *value);
void gsf_doc_prop_glue_set_val (GsfDocProp *prop, GValue *value);


#endif
