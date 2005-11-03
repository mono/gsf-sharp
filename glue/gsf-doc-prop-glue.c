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

#include <gsf/gsf-doc-meta-data.h>
#include "gsf-doc-prop-glue.h"

void
gsf_doc_prop_glue_get_val (GsfDocProp const *prop, GType *type, GValue *value) 
{
	GValue const *prop_val;
	
	if (prop == NULL)
	  return;
	
	prop_val = gsf_doc_prop_get_val (prop);
	
	if (prop_val != NULL && G_IS_VALUE (prop_val)) {
	  
	  *type = G_VALUE_TYPE (prop_val);
	  
	  g_value_init (value, *type);
	  g_value_copy (prop_val, value);
	  
	  /*
	    printf ("Type == %d, G_TYPE_STRING=%d, G_VALUE_TYPE (prop_val)=%d\n", 
	    *type, G_TYPE_STRING, G_VALUE_TYPE (prop_val));
	    */
  }    
}

void
gsf_doc_prop_glue_set_val (GsfDocProp *prop, GValue *value)
{
	GValue prop_val;
	
	if (prop == NULL)
	  return;
	
	if (value == NULL || !G_IS_VALUE (value))
	  return;
	
	g_value_init (&prop_val, G_VALUE_TYPE (value));
	g_value_copy (value, &prop_val);
	
	gsf_doc_prop_set_val (prop, &prop_val);
}
