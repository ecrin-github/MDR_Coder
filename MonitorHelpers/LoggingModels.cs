﻿using Dapper.Contrib.Extensions;

namespace MDR_Coder;


[Table("sf.source_parameters")]
public class Source
{
    public int id { get; }
    public string? source_type { get; }
    public int? preference_rating { get; }
    public string? database_name { get; }
    public string? db_conn { get; set; }
    public bool? has_study_tables { get; }
    public bool? has_study_topics { get; }
    public bool? has_study_conditions { get; }
    public bool? has_study_features { get; }
    public bool? has_study_iec{ get; }
    public bool? has_study_people{ get; }
    public bool? has_study_organisations{ get; }
    public bool? has_study_references { get; }
    public bool? has_study_relationships { get; }
    public bool? has_study_countries { get; }
    public bool? has_study_locations { get; }
    public string? study_iec_storage_type { get; }
    public bool? has_object_datasets { get; }
    public bool? has_object_instances { get; }
    public bool? has_object_dates { get; }
    public bool? has_object_descriptions { get; }
    public bool? has_object_identifiers { get; }
    public bool? has_object_people { get; }
    public bool? has_object_organisations { get; }
    public bool? has_object_topics { get; }
    public bool? has_journal_details { get; }
    public bool? has_object_rights { get; }
    public bool? has_object_relationships { get; }

}



[Table("sf.coding_events")]
public class CodeEvent
{
    [ExplicitKey]
    public int? id { get; set; }
    public int? source_id { get; set; }
    public DateTime? time_started { get; set; }
    public DateTime? time_ended { get; set; }
    public int num_orgs_to_match { get; set; }
    public int num_countries_to_match { get; set; }
    public int num_cities_to_match { get; set; }
    public int num_topics_to_match { get; set; }
    public int num_conditions_to_match { get; set; }
    public int num_publishers_to_match { get; set; }
    public string? comments { get; set; }

    public CodeEvent(int? _id, int? _source_id)
    {
        id = _id;
        source_id = _source_id;
        time_started = DateTime.Now;
        num_orgs_to_match = 0;
        num_countries_to_match = 0;
        num_cities_to_match = 0;
        num_topics_to_match = 0;
        num_conditions_to_match = 0;
        num_publishers_to_match = 0;
    }
}



[Table("sf.source_data_studies")]
public class StudyFileRecord
{
    public int? id { get; set; }
    public int? source_id { get; set; }
    public string? sd_id { get; set; }
    public string? remote_url { get; set; }
    public DateTime? last_revised { get; set; }
    public bool? assume_complete { get; set; }
    public int? download_status { get; set; }
    public string? local_path { get; set; }
    public int? last_saf_id { get; set; }
    public DateTime? last_downloaded { get; set; }
    public int? last_harvest_id { get; set; }
    public DateTime? last_harvested { get; set; }
    public int? last_import_id { get; set; }
    public DateTime? last_imported { get; set; }

    // constructor when a revision data can be expected (not always there)
    public StudyFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          DateTime? _last_revised, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        last_revised = _last_revised;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }

    // constructor when an 'assumed complete' judgement can be expected (not always there)
    public StudyFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          bool? _assume_complete, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        assume_complete = _assume_complete;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }


    public StudyFileRecord()
    { }

}


[Table("sf.source_data_objects")]
public class ObjectFileRecord
{
    public int? id { get; set; }
    public int? source_id { get; set; }
    public string? sd_id { get; set; }
    public string? remote_url { get; set; }
    public DateTime? last_revised { get; set; }
    public bool? assume_complete { get; set; }
    public int? download_status { get; set; }
    public string? local_path { get; set; }
    public int? last_saf_id { get; set; }
    public DateTime? last_downloaded { get; set; }
    public int? last_harvest_id { get; set; }
    public DateTime? last_harvested { get; set; }
    public int? last_import_id { get; set; }
    public DateTime? last_imported { get; set; }

    // constructor when a revision data can be expected (not always there)
    public ObjectFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          DateTime? _last_revised, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        last_revised = _last_revised;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }

    // constructor when an 'assumed complete' judgement can be expected (not always there)
    public ObjectFileRecord(int? _source_id, string? _sd_id, string? _remote_url, int? _last_saf_id,
                                          bool? _assume_complete, string? _local_path)
    {
        source_id = _source_id;
        sd_id = _sd_id;
        remote_url = _remote_url;
        last_saf_id = _last_saf_id;
        assume_complete = _assume_complete;
        download_status = 2;
        last_downloaded = DateTime.Now;
        local_path = _local_path;
    }

    public ObjectFileRecord()
    { }

}
